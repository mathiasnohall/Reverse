'use strict';

reverseApp.controller('reverseController', ['$scope', 'reverseService', function ($scope, reverseService) {
    
    $scope.submitForm = function () {
        reverseService.postForm($scope.form).then(function (data) {
            $scope.response = data;
            $scope.success = true;
        });
    }
}]);