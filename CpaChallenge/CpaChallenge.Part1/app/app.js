var app = angular.module('app', ['ngRoute']);

app.config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when("/", { templateUrl: "/app/view/view.html", controller: "homeController" })
}]);