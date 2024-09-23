    @extends('layout')
    @section('content')
    <div class="container py-3">
        <h1 class="text-center display-5">Összes pizzánk</h1>
        <b>Rendezés</b>
        <table class="table">
            <thead>
                <tr>
                    <th>Név</th>
                    <th>Feltétek</th>
                    <th>24 cm</th>
                    <th>32 cm</th>
                    <th>45 cm</th>
                    <th></th>
                </tr>
                @foreach($result as $pizza)

                    @if ($pizza->akcios == 1)
                        <tr class="text-danger">
                            <?php
                                $akcios = $pizza->ar - ($pizza->ar * 0.1);
                                $akcios32 = $akcios * 1.25;
                                $akcios45 = $akcios * 1.5;
                            ?>
                        <td><a href="/adatlap/{{$pizza->id}}" style="text-decoration: none; color: red;">{{ $pizza->nev}}</a></td>
                            <td>{{ $pizza->feltet }}</td>
                            <td>{{ $akcios }}</td>
                            <td>{{ $akcios32 }}</td>
                            <td>{{ $akcios45 }}</td>
                            <td>Akciós</td>
                        </tr>
                    @else

                    <tr>
                        <?php
                            $akcios32 = $pizza->ar * 1.25;
                            $akcios45 = $pizza->ar * 1.5;
                        ?>
                        <td><a href="/adatlap/{{$pizza->id}}" style="text-decoration: none; color: black;">{{ $pizza->nev}}</a></td>
                        <td>{{ $pizza->feltet }}</td>
                        <td>{{ $pizza->ar }}</td>
                        <td>{{ $akcios32 }}</td>
                        <td>{{ $akcios45 }}</td>
                        <td></td>
                    </tr>
                    @endif

                @endforeach
            </thead>
            <tbody></tbody>

        </table>
    </div>
    @endsection
