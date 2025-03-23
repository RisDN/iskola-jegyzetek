@extends('layout')

@section('content')
    <div class="row d-flex justify-content-center align-items-center my-4">
        <div class="col-md-8">
            <div class="search">
                <i class="fa fa-search"></i>
                <form action="/kereses" method="POST">
                    @csrf
                    <input type="text" class="form-control" name="search" placeholder="Megálló neve, pl: Somogyi utca">
                    <button class="btn btn-dark">Keresés</button>
                    @error('search')
                        <p class="text-danger">{{ $message }}</p>
                    @enderror
                </form>
            </div>
        </div>
    </div>
    @isset($search)
        @if (count($search) > 0)
            <p class="fs-5">A keresés eredménye:</p>
            @foreach ($search as $megallo)
                <p class="fs-5"><a href="/megallo/{{ $megallo->megallo_id }}">{{ $megallo->nev }}</a></p>
            @endforeach
        @else
            <p class="fs-5">A keresés nem hozott eredményt...</p>
        @endif
    @endisset
@endsection
