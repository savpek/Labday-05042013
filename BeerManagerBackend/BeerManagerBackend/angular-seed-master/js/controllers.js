'use strict';

/* Controllers */


function MyCtrl1($scope,baari) {
    $scope.firstName = "Pekka";
    $scope.lastName = "Savolainen";
    $scope.login = function() {
        baari.server.enterBar($scope.firstName, $scope.lastName);
    };
}
MyCtrl1.$inject = ['$scope',"baari"];

function UserListControl($scope, baari) {
    $scope.users = [];

    baari.client.refreshUserList = function (userlist) {
        $scope.users = userlist;
        $scope.$digest();
    };
}
UserListControl.$inject = ['$scope', "baari"];

function MyCtrl2($scope, baari) {
    $scope.currentMessage = "";
    
    $scope.messages = [];
    $scope.messages.push("HELLO!");

    baari.client.addMessage = function (message) {
        $scope.messages.push(message);
        $scope.$digest();
    };

    $scope.send = function() {
        baari.server.send($scope.currentMessage);
    };


}
MyCtrl2.$inject = ['$scope',"baari"];