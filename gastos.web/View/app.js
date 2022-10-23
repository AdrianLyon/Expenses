var app = angular.module('app',['ngRoute']);

app.config(function($routeProvider, $locationProvider) {
    $locationProvider.hashPrefix('')
	$routeProvider
		.when('/Taxes', {
			templateUrl: '/gastos.web/View/components/gastos/gastoView.html',
			controller: 'gastoCtrl'
		})
		.otherwise({
			redirectTo: '/'
		});
});