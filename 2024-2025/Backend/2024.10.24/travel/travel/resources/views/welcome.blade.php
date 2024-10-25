@extends('layout')


@section('content')
<h1 class="text-center display-6 py-3">Utazásaink</h1>

<table class="table table-striped table-hover table-bordered">

    <thead>
        <tr class="fw-bold">
            <td>Uticél</td>
            <td>Utazás neve</td>
            <td>Időtartam</td>
            <td>Ár</td>
        </tr>
    </thead>
    <tbody>
        @foreach($result as $travel)
        <tr>
            <td>{{$travel->uticel}}</td>
            <td><a href="/utazas/{{$travel->id}}">{{$travel->megnevezes}}</a></td>
            <td>{{$travel->idotartam}}</td>
            <td>{{number_format($travel->ar, 0, " ", " ")}} Ft / fő</td>
        </tr>
        @endforeach
    </tbody>

</table>
@endsection
