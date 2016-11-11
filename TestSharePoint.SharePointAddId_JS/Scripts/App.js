'use strict';

ExecuteOrDelayUntilScriptLoaded(initializePage, "sp.js");

function initializePage() {
    var context = SP.ClientContext.get_current();
    var user = context.get_web().get_currentUser();
    var oWebsite = context.get_web();

    var parentContext = null;
    var parentWebSite = null;
    // This code runs when the DOM is ready and creates a context object which is needed to use the SharePoint object model
    $(document).ready(function () {
        getUserName();

        retrieveParentSite('http://k2/sites/test');
    });

    function retrieveParentSite(url) {
        var parentCtx = new SP.AppContextSite(context, 'http://K2/sites/test');
        var parentWeb = parentCtx.get_web();
        context.load(parentWeb);
        //parentContext = new SP.ClientContext(url);
        //parentWebSite = parentContext.get_web();
        //parentContext.load(parentWebSite);

        context.executeQueryAsync(function () {
            //success
            $('#content').text(parentWeb.get_title());
            GetLists(parentWeb);

        }, function (sender, args) {//failure
            $('#error').text(args.get_message());
        });
    }
    function GetLists(web) {
        var lists = web.get_lists();
        context.load(lists);

        context.executeQueryAsync(function () {
            //success
            var listsEnumerator = lists.getEnumerator();
            var list = document.getElementById("ulLists");

            while (listsEnumerator.moveNext()) {
                var oList = listsEnumerator.get_current();
                var listInfo = "";
                listInfo += 'Title: ' + oList.get_title() + ' Created: ' +
                    oList.get_created().toString() + '\n';


                var li = document.createElement("li");
                li.appendChild(document.createTextNode(listInfo));
                list.appendChild(li);

            }
        },
            function (sender, args) {//failure
                $('#error').text(args.get_message());
            });



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
