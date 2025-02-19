@extends('layout')

@section('content')
    <div class="text-center m-5">
        @foreach ($kontinensek as $kontinens)
            <a class="btn btn-outline-dark" href="{{ '/orszagok/' . $kontinens->kontinens_id }}">{{ $kontinens->nev }}</a>
        @endforeach
    </div>

    <h2 class="text-center display-6 py-3">{{ $kontinens->nev }} országai</h2>


    <table class="table table-striped table-bordered">
        <tr>
            <th>#</th>
            <th>Név</th>
            <th>Főváros</th>
            <th>Népesség</th>
            <th>Terület</th>
            <th>Népsűrűség</th>
        </tr>
        @php
            $index = 0;
        @endphp
        @foreach ($result as $orszag)
            @php
                $index++;
            @endphp
            <tr>
                <td>{{ $index }}</td>
                <td>{{ $orszag->nev }}</td>
                <td>{{ $orszag->fovaros }}</td>
                <td>{{ number_format($orszag->nepesseg, 0, ' ', ' ') }} fő</td>
                <td>{{ number_format($orszag->terulet, 0, ' ', ' ') }} km2</td>
                <td>{{ number_format($orszag->nepsuruseg, 0, ' ', ' ') }} fő / km2</td>
            </tr>
        @endforeach
    </table>
@endsection
