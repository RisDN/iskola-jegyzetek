@extends('layout')


@section('content')
    <div class="container mt-5">
        <div class="row row-cols-1 row-cols-md-2 row-cols-lg-4">

            <div class="card-group col">
                <div class="card">
                    <img src="{{ asset('img/category-soup.jpg') }}" class="card-img-top" alt="">
                    <div class="card-body">
                        <h5 class="card-title">Levesek</h5>
                        @foreach ($etelek as $etel)
                            @if ($etel->besorolas == 'l')
                                <p><a href="/etel/{{ $etel->etelid }}">{{ $etel->nev }}</a></p>
                            @endif
                        @endforeach
                    </div>
                </div>

            </div>

            <div class="card-group col">

                <div class="card">
                    <img src="{{ asset('img/category-meal.jpg') }}" class="card-img-top" alt="">
                    <div class="card-body">
                        <h5 class="card-title">Készételek</h5>
                        @foreach ($etelek as $etel)
                            @if ($etel->besorolas == 'k')
                                <p><a href="/etel/{{ $etel->etelid }}">{{ $etel->nev }}</a></p>
                            @endif
                        @endforeach
                    </div>
                </div>

            </div>

            <div class="card-group col">

                <div class="card">
                    <img src="{{ asset('img/category-stew.jpg') }}" class="card-img-top" alt="">
                    <div class="card-body">
                        <h5 class="card-title">Főzelékek</h5>
                        @foreach ($etelek as $etel)
                            @if ($etel->besorolas == 'f')
                                <p><a href="/etel/{{ $etel->etelid }}">{{ $etel->nev }}</a></p>
                            @endif
                        @endforeach
                    </div>
                </div>

            </div>

            <div class="card-group col">

                <div class="card">
                    <img src="{{ asset('img/category-dessert.jpg') }}" class="card-img-top" alt="">
                    <div class="card-body">
                        <h5 class="card-title">Édességek</h5>
                        @foreach ($etelek as $etel)
                            @if ($etel->besorolas == 'é')
                                <p><a href="/etel/{{ $etel->etelid }}">{{ $etel->nev }}</a></p>
                            @endif
                        @endforeach
                    </div>
                </div>

            </div>
        </div>
    </div>
@endsection
