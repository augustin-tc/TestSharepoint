'use strict';

ExecuteOrDelayUntilScriptLoaded(initializePage, "sp.js");

function initializePage()
{
    var context = SP.ClientContext.get_current();
    var user = context.get_web().get_currentUser();
    var oWebsite = context.get_web();
    // This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
    $(document).ready(function () {
        getUserName();
        //getSiteTitle();
        retrieveWebSite('http://k2/sites/test')
    });

    function getSiteTitle() {
       
        
        context.load(web);
        var SiteTitle = web.get_title();

        $('#content').text('Site title : ' + SiteTitle);
    }


    function retrieveWebSite(siteUrl) {
        
        
        context.load(oWebsite);

        context.executeQueryAsync(onQuerySucceeded , onQueryFailed);
          
    }

    function onQuerySucceeded(sender, args) {
        alert('Title: ' + oWebsite.get_title() +
            ' Description: ' + oWebsite.get_description());
    }

    function onQueryFailed(sender, args) {
        alert('Request failed. ' + args.get_message() +
            '\n' + args.get_stackTrace());
    }


    // This function prepares, loads, and then executes a SharePoint query to get the current users information
    function getUserName() {
        context.load(user);
        context.executeQueryAsync(onGetUserNameSuccess, onGetUserNameFail);
    }

    // This function is executed if the above call is successful
    // It replaces the contents of the 'message' element with the user name
    function onGetUserNameSuccess() {
        $('#message').text('Hello ' + user.get_title());
    }

    // This function is executed if the above call fails
    function onGetUserNameFail(sender, args) {
        alert('Failed to get user name. Error:' + args.get_message());
    }
}
