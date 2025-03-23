<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Szeged</title>
    <link rel="stylesheet" href="{{ asset('assets/css/bootstrap.css') }}">
    <link rel="stylesheet" href="{{ asset('assets/css/mystyle.css') }}">
    <link href="{{ asset('assets/fontawesome/css/fontawesome.css') }}" rel="stylesheet">
    <link href="{{ asset('assets/fontawesome/css/solid.css') }}" rel="stylesheet">
    <link rel="shortcut icon" href="{{ asset('img/tram.png') }}" type="image/x-icon">
    <script src="{{ asset('assets/js/bootstrap.bundle.js') }}"></script>
</head>

<body class="bg-light">
    <div class="container-fliud bg-dark">
        <nav class="navbar navbar-expand-sm bg-dark navbar-dark container px-2">
            <i class="fa-solid fa-train-subway me-2"></i><a class="navbar-brand" href="/">Szeged</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="collapsibleNavbar">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="/jaratok">Járatok</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/kereses">Megálló keresése</a>
                    </li>
                </ul>
            </div>
        </nav>
    </div>
    <main class="container pb-2">

        @yield('content')

    </main>
    <footer class="container-fluid text-center bg-dark">
        <div class="container text-white pt-4 pb-3">
            <p>Készítette: Rostás András Péter - 13.B</p>
        </div>
    </footer>
</body>

</html>
