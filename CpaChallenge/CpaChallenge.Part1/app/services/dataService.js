angular.module('app').factory('dataService', function ($http) {

    var resultUrl = "/api/results";
    var result2Url = "/api/results2";    

    var dataService = {
        getResults: getResults,
        getResults2: getResults2
    };

    
    function getResults () {
        return $http.get(resultUrl);
    };

    function getResults2() {
        return $http.get(result2Url);
    };

    return dataService;
});