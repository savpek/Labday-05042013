'use strict';


// Declare app level module which depends on filters, and services
angular.module('myApp', ['myApp.filters', 'myApp.services', 'myApp.directives']).
  config(['$routeProvider', function($routeProvider) {
    $routeProvider.when('/chat', {templateUrl: 'partials/ChatPage.html', controller: ChatPageController});
    $routeProvider.otherwise({redirectTo: '/chat'});
  }]);
