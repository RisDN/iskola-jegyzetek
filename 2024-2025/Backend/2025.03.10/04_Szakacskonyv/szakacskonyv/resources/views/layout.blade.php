<!DOCTYPE html>
<html lang="hu">

<head>
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="{{ asset('assets/css/bootstrap.css') }}">
    <link rel="stylesheet" href="{{ asset('assets/css/mystyle.css') }}">
    <link href="{{ asset('assets/fontawesome/css/fontawesome.css') }}" rel="stylesheet">
    <link href="{{ asset('assets/fontawesome/css/solid.css') }}" rel="stylesheet">
    <link rel="shortcut icon" href="{{ asset('img/foodbook.png') }}" type="image/x-icon">
    <meta charset="UTF-8">
    <title>FoodBook</title>
</head>

<body>
    <div class="container-fluid bg-dark">
        <nav class="navbar navbar-expand bg-dark navbar-dark container px-2">
            <i class="fa-solid fa-utensils me-2"></i><a class="navbar-brand" href="/">FoodBook</a>
            <div class="collapse navbar-collapse">
                <ul class="navbar-nav ms-auto">
                    <li class="nav-item">
                        <a class="nav-link" href="/kereses"><i class="fa-solid fa-magnifying-glass"></i></a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <main class="container pb-2">
        @yield('content')
    </main>

    <footer class="container text-center my-5">
        <hr>
        Készítette: Rostás András Péter - 13.B
    </footer>

</body>

</html>
