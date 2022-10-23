app.controller("gastoCtrl", function ($scope, employees) {
    employees.then(function(data){
    
        $scope.config.myData=data;
        });
        $scope.config = {
          heads: ['name', 'age', 'company', 'tech']
        };
});
app.directive('pgnTable', ['$compile',
  function($compile) {
    return {
      restrict: 'E',
      templateUrl: '/gastos.web/View/Directives/tabletemplate.html',
      replace: true,
      scope: {
        conf: "="
      },
      controller: function($scope) {
      
      $scope.currentPage=1;
      $scope.numLimit=5;
      $scope.start = 0;
      $scope.$watch('conf.myData',function(newVal){
        if(newVal){
         $scope.pages=Math.ceil($scope.conf.myData.length/$scope.numLimit);
   
        }
      });
      $scope.hideNext=function(){
        if(($scope.start+ $scope.numLimit) < $scope.conf.myData.length){
          return false;
        }
        else 
        return true;
      };
       $scope.hidePrev=function(){
        if($scope.start===0){
          return true;
        }
        else 
        return false;
      };
      $scope.nextPage=function(){
        console.log("next pages");
        $scope.currentPage++;
        $scope.start=$scope.start+ $scope.numLimit;
        console.log( $scope.start)
      };
      $scope.PrevPage=function(){
        if($scope.currentPage>1){
          $scope.currentPage--;
        }
        console.log("next pages");
        $scope.start=$scope.start - $scope.numLimit;
        console.log( $scope.start)
      };
      },
      compile: function(elem) {
        return function(ielem, $scope) {
          $compile(ielem)($scope);
        };
      }
    };
  }
]);
