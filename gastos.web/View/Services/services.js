var mainModule = angular.module('app',[]);
mainModule.factory("employees",function($http,$q){
  

 var self=this;
 var defer=$q.defer();
   $http.get("/gastos.web/View/employees.json").success(function(data){
  var empData=data.employees;
    defer.resolve(empData);
    
  })
 return defer.promise;
});