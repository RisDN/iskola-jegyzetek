```blade
@extends('layout')

@section('content')
<h1 class="text-center display-6 py-3">{{$uticel}}</h1>
<hr>

<div class="container">
    @foreach ($result as $travel)
    <div class="row pb-5">
        <div class="col-12 col-md-6">
            <img class="img-fluid w-100" src="{{ asset('img/' . $travel->id . '.jpg') }}">
        </div>
        <div class="col-12 col-md-6">

            <div class="py-2">
                <span class="fw-bold">Program megnevezése:</span> <a href="/utazas/{{$travel->id}}">{{$travel->megnevezes}}</a>
            </div>

            <div class="py-2">
                <span class="fw-bold">Időtartam:</span> {{$travel->idotartam}}
            </div>

            <div class="py-2">
                <span class="fw-bold">Ár:</span> {{number_format($travel->ar, 0, " ", " ")}} Ft / fő
            </div>

        </div>
    </div>
    @endforeach
</div>
@endsection
