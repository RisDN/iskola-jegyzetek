@extends('layout')

@section('content')
<h1 class="text-center display-6 py-3">{{$result->megnevezes}}</h1>

<div class="container">
    <div class="row">
        <div class="col-12 col-md-6">
            <img class="img-fluid w-100" src="{{ asset('img/' . $result->id . '.jpg') }}">
        </div>
        <div class="col-12 col-md-6">

            <div class="py-2">
                <span class="fw-bold">Uticél:</span>
                <a href="/uticel/{{$result->uticel}}">{{$result->uticel}}</a>
            </div>

            <div class="py-2">
                <span class="fw-bold">Program megnevezése:</span> {{$result->megnevezes}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Utazás:</span> {{$result->utazas}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Szállás:</span> {{$result->szallas}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Szoba:</span> {{$result->szoba}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Időtartam:</span> {{$result->idotartam}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Ár:</span> {{number_format($result->ar, 0, " ", " ")}} Ft / fő
            </div>

        </div>
    </div>
</div>

@endsection
