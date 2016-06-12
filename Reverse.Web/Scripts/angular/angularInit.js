"use strict";

var reverseApp = angular.module('reverseApp', ['services']);
var services = angular.module('services', ['ngResource']);

reverseApp.run(['$rootScope', '$document', function ($rootScope, $document) {
    $rootScope.language = $document[0].documentElement.lang;
}]);

reverseApp.config(['$locationProvider', function ($locationProvider) {

    $locationProvider.html5Mode({
        enabled: true,
        requireBase: false
    });
}]);