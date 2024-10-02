@extends('layout')


@section("content")
    <h1 class="text-center display-5">Húzások - {{$result[0]->ev}}</h1>
    <h3 class="display-6">Válassz egy évet:</h3>

    <div class="mt-4">
        @foreach ($result as $lotto)

        <a class="btn btn-primary rounded fs-3 m-1 text-center" href="/adatlap/{{$lotto->ev}}/{{$lotto->het}}">
            {{ $lotto->het }}. hét
        </a>

    @endforeach
    </div>


@endsection
