angular.module('app').controller('homeController', ['$scope', 'dataService', function ($scope, dataService) {
    
    dataService.getResults().then(function (result) {
        $scope.data = result;
    });

    dataService.getResults2().then(function (result) {
        $scope.data2 = result;
    });

}]);