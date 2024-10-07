    @extends('layout')
    @section('content')
    <div class="container pb-2">
        <h1 class="text-center display-6 py-3">Cat pics</h1>
        <div class="row">
        @foreach ($result as $cat)

            <div class="col-md-3">
                <a href="/cat/{{$cat->id}}"><img class="img-fluid" src="{{{asset("/img/" . $cat->id . ".jpg")}}}"></a>
                <hr>
            </div>

        @endforeach
        </div>
    </div>
    @endsection
