@extends('layout')


@section("content")
    <h1 class="text-center display-5">Mikor volt ötös?</h1>
    <h3 class="display-6 fs-4">Válassz hetet, hogy megnézd a húzás adatait:</h3>

    <table class="table table-striped table-bordered border-secondary-subtle">
        <thead>
            <tr class="text-bold">
                <th>#</th>
                <th>Év</th>
                <th>Hét</th>
                <th>Darab</th>
                <th>HUF</th>
            </tr>
        </thead>
        <tbody>
            @php $i = 1; @endphp
            @foreach ($result as $oto)
            <tr>
                <td>{{ $i}}</td>
                <td>{{ $oto->ev }}</td>
                <td>{{ $oto->het }}. hét</td>
                <td>{{ $oto->talalat5_db }} darab</td>
                <td>{{ str_replace(',', ' ', number_format($oto->talalat5_huf)) }} Ft</td>
            </tr>
            @php $i++; @endphp
            @endforeach
        </tbody>
    </table>

@endsection
