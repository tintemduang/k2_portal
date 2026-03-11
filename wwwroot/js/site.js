// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

document.querySelectorAll('.dropdown-submenu .dropdown-toggle')
.forEach(function(element){

    element.addEventListener('click', function(e){

        e.preventDefault();
        e.stopPropagation();

        let submenu = this.nextElementSibling;

        // ปิด submenu อื่นก่อน
        document.querySelectorAll('.dropdown-submenu .dropdown-menu')
        .forEach(function(menu){
            if(menu !== submenu){
                menu.classList.remove('show');
            }
        });

        // toggle อันที่กด
        submenu.classList.toggle('show');
    });

});

document.querySelectorAll('.dropdown').forEach(function(dropdown){

    dropdown.addEventListener('hide.bs.dropdown', function () {

        this.querySelectorAll('.dropdown-menu').forEach(function(menu){
            menu.classList.remove('show');
        });

    });

});