'use strict';

/* Controllers */


function MyCtrl1($scope) {
    $scope.firstName = "Pekka";
    $scope.lastName = "Savolainen";
}
MyCtrl1.$inject = ['$scope'];


function MyCtrl2($scope) {
    $scope.currentMessage = "";
    
    $scope.messages = [];
    $scope.messages.push("HELLO!");
    
    var chat = $.connection.chat;
    
    chat.client.addMessage = function (message) {
        $scope.messages.push(message);
        $scope.$digest();
    };

    $scope.send = function() {
        chat.server.send($scope.currentMessage);
    };

    $.connection.hub.start().done(function () {
        chat.server.getUser().done(function (person) {
            console.log(person);
        });
    });
}
MyCtrl2.$inject = ['$scope'];