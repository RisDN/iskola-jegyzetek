    @extends('layout')
    @section('content')
    <div class="container py-3">
        <h1 class="text-center display-5">Akciós pizzák</h1>

        <table class="table">
            <thead>
                <tr>
                    <th>Név</th>
                    <th>Feltétek</th>
                    <th>24 cm</th>
                    <th>32 cm</th>
                    <th>45 cm</th>
                </tr>
            </thead>

            <tbody>
                @foreach ($result as $pizza)
                    <?php
                        $alapAr = $pizza->ar - ($pizza->ar * 0.1);
                        $ar32 = $alapAr * 1.25;
                        $ar45 = $alapAr * 1.5;
                    ?>
                    <tr>
                        <td>{{ $pizza->nev }}</td>
                        <td>{{ $pizza->feltet }}</td>
                        <td>{{ $alapAr }}</td>
                        <td>{{ $ar32 }}</td>
                        <td>{{ $ar45 }}</td>
                    </tr>
                @endforeach

            </tbody>
        </table>
    </div>
    @endsection
