<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Travel</title>
    <link rel="stylesheet" href="{{{asset("css/bootstrap.css")}}}">
    <link rel="stylesheet" href="{{{asset("css/mystyle.css")}}}">
    <link href="{{{asset("fontawesome/css/fontawesome.css")}}}" rel="stylesheet">
    <link href="{{{asset("fontawesome/css/solid.css")}}}" rel="stylesheet">
    <script src="{{{asset("js/bootstrap.bundle.js")}}}"></script>
</head>
<body class="bg-light">
    <nav class="navbar navbar-expand-lg bg-dark navbar-dark">
        <div class="container bg-dark">
            <i class="fa-solid fa-umbrella-beach me-2"></i>
            <a class="navbar-brand" href="/">Happy travel</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#collapsibleNavbar">
              <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="collapsibleNavbar">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Drezda">Drezda</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Dubai">Dubai</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Erdély">Erdély</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Nürnberg">Nürnberg</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Prága">Prága</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Salzkammergut">Salzkammergut</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="/uticel/Tátra">Tátra</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <main class="container pb-2">
        @yield('content')
    </main>
    <footer class="container text-center">
        <hr>
        <p>- Happy Travel - E-mail: <a href="mailto:">hello@happytravel.hu</a> - Tel.: <a href="tel:+">06 1 123-4567</a> -</p>
    </footer>
</body>
</html>
