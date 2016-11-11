#Normalement, SharePoint 2013 n’accepte pas les certificats auto-signés. Ainsi, lorsque vous utilisez un certificat auto-signé pour le débogage, ajoutez les lignes suivantes pour contourner l’exigence normale de SharePoint que les applications web à distance utilisent le protocole HTTPS quand elles appellent SharePoint. À défaut, vous obtiendrez un message 403 Interdit lorsque l’application web à distance appellera SharePoint en utilisant un certificat auto-signé. Vous pourrez annuler cette action dans une procédure ultérieure. Le contournement de l’exigence d’utilisation du protocole HTTPS a pour effet que les demandes de l’application web à distance adressées à SharePoint ne sont pas chiffrées, mais que le certificat continue à être utilisé comme émetteur approuvé de jetons d’accès, ce qui est l’objectif principal dans des Compléments SharePoint à haut niveau de fiabilité.

$serviceConfig = Get-SPSecurityTokenServiceConfig
$serviceConfig.AllowOAuthOverHttp = $true
$serviceConfig.Update()


$publicCertPath = "C:\Certs\SharePointAddin.pfx"
$certificate = New-Object System.Security.Cryptography.X509Certificates.X509Certificate2($publicCertPath)

# Ajoutez la ligne suivante pour vous assurer que SharePoint traite le certificat comme une autorité racine.

New-SPTrustedRootAuthority -Name "SharePointAddin" -Certificate $certificate 

#Ajoutez la ligne suivante pour obtenir l'ID du domaine d'autorisation.

$realm = Get-SPAuthenticationRealm

#Votre application web à distance utilisera un jeton d’accès pour accéder aux données SharePoint. Le jeton d’accès doit être émis par un émetteur de jeton approuvé par SharePoint. Dans un Complément SharePoint à haut niveau de fiabilité, le certificat est l’émetteur de jeton. Ajoutez les lignes suivantes pour créer un ID de l’émetteur au format requis par SharePoint : specific_issuer_GUID@realm_GUID.

$specificIssuerId = "ab2775e1-24c9-4ea2-a5c8-b7cbb362fe6c"
$fullIssuerIdentifier = $specificIssuerId + '@' + $realm 


#La valeur $specificIssuerId doit être un GUID car, dans un environnement de production, chaque certificat doit avoir un émetteur unique. Toutefois, dans ce contexte où vous utilisez le même certificat pour déboguer tous les compléments à haut niveau de fiabilité, vous pouvez coder en dur la valeur. Si, pour une raison quelconque, vous utilisez un GUID différent de celui utilisé ici, assurez-vous que toutes les lettres du GUID sont en minuscules. L’infrastructure SharePoint exige actuellement l’utilisation de lettres minuscules pour les GUID d’émetteur de certificat.
#Ajoutez les lignes suivantes pour enregistrer le certificat sous la forme d’un émetteur de jeton approuvé. Le paramètre -Name doit être unique. Ainsi, dans une configuration de production, il est courant d’utiliser un GUID pour une partie ou la totalité du nom. Toutefois, dans ce contexte, vous pouvez utiliser un nom convivial. Le commutateur –IsTrustBroker est nécessaire pour garantir que vous pouvez utiliser le même certificat pour tous les compléments à haut niveau de fiabilité que vous développez. La commande iisreset est requise pour que votre émetteur de jeton soit immédiatement enregistré. Sans cette dernière, il se peut que vous deviez patienter jusqu’à 24 heures avant que le nouvel émetteur soit enregistré.

New-SPTrustedSecurityTokenIssuer -Name "SharePointAddin" -Certificate $certificate -RegisteredIssuerName $fullIssuerIdentifier –IsTrustBroker
iisreset 

