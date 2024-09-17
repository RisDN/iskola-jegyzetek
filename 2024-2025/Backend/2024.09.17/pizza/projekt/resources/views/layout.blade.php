<!DOCTYPE html>
<html lang="hu">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Pizza Queen</title>
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/mystyle.css">
</head>
<body class="bg-primary">
    <div class="container-fluid bg-dark">
        <nav class="container navbar navbar-expand-sm bg-dark navbar-dark">
            <a class="navbar-brand" href="/">Pizza Queen</a>
            <ul class="navbar-nav ms-auto">
                <li class="nav-item">
                    <a class="nav-link" href="/akciosok">Akciós pizzák</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/all">Összes pizza</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link" href="/rnd">Nem tudok választani</a>
                </li>
            </ul>
        </nav>
    </div>
    @yield('content')
    <footer class="text-center">
        <p>Tel: <a href="tel:36699090901">+36699090901</a></p>
    </footer>
</body>
</html>
