
(function () {

    var app = angular.module('myApp', []);



    angular.module('myApp').controller('myController', myController);
    myController.$inject = ['id', 'name', 'value'];

    function myController(id, name, value) {

        var vm = this;

        vm.id = id;
        vm.name = name;
        vm.value = value;;
    }
})();
