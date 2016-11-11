
    $(document).ready(function () {
        $('#ProviderTableContainer').jtable({
            title: 'Table of providers',
            actions: {
                listAction: '/ProviderList'
            },
            fields: {
                Name: {
                    title: "Name"
                },
                Coutry: {
                    title: 'Country'
                },
                Address: {
                    title: 'Address'
                }
            }
        });
    });


    
