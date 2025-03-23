@extends('layout')

@section('content')
    <p class="line-p fs-5 mt-4 text-center">
        @foreach ($jaratok as $jarat)
            <a class="line-number" style="background-color: {{ $jarat->hatterszin }};"
                href="/jarat/{{ $jarat->jaratok_id }}"><span
                    style="color: {{ $jarat->betuszin }};">{{ $jarat->jaratszam }}</span></a>
        @endforeach
    </p>
    <img src="{{ asset('img/map_of_szeged.png') }}" class="img-fluid" alt="">
@endsection
