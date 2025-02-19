<!DOCTYPE html>
<html lang="hu">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Világ országai</title>
    <link rel="stylesheet" href="{{ asset('/css/bootstrap.css') }}">
    <link rel="stylesheet" href="{{ asset('/css/mystyle.css') }}">
</head>

<body class="bg-light">
    <header>
        <h1>Világ országai</h1>
    </header>
    <div class="container-fliud bg-dark">
        <nav class="navbar navbar-expand bg-dark navbar-dark container">
            <ul class="navbar-nav">
                <li class="nav-item">
                    <a class="nav-link" href="/">Főoldal</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/kontinensek/5">Kontinensek</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/orszagok/5">Országok</a>
                </li>
            </ul>
        </nav>
    </div>

    <main class="container pb-2">
        @yield('content')
    </main>

    <footer class="container text-center">
        <hr>
        <p>Rostás András Péter - 13.B</p>
    </footer>

</body>

</html>
