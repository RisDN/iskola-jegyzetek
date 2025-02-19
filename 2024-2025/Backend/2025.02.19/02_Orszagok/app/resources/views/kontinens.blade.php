@extends('layout')

@section('content')
    <h2 class="text-center display-6 py-3">{{ $result->nev }}</h2>

    <div class="container">
        <div class="row">
            <div class="col">

                <img src="{{ asset('/img/' . $result->kontinens_id . '.jpg') }}" class="img-fluid" alt="gec">

            </div>
            <div class="col">asddas</div>
        </div>
    </div>
@endsection
