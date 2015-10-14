Passing MVC variables to AngularJS using Razor — Edit

Code for blog post http://enlighten-media.net/blog/general/passing-variables-from-mvc-to-angularjs-using-razor

**Index.cshtml**
```C#
@section scripts {
    <script src="~/Scripts/angular.js"></script>
    <script src="~/App/app.js"></script>
    <script>
        angular.module('myApp').value({
            id: '@Model.Id',
            name: '@Model.Name',
            value: @Model.Value,
        });
    </script>
}
```


**app.js**

```JavaScript

(function () {

    angular.module('myApp', []);
    
    angular.module('myApp').controller('myController', myController);
    myController.$inject = ['id', 'name', 'value'];

    function myController(id, name, value) {

        var vm = this;

        vm.id = id;
        vm.name = name;
        vm.value = value;;
    }
})();
```
