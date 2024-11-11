@extends("layout")



@section('content')
<h1 class="text-center display-6 pt-3 pb-1">Nagykátai járás települései</h1>
<hr class="w-50 mx-auto">

<table class="table table-striped table-bordered">

    <thead>
        <tr class="fw-bold">
            <td>#</td>
            <td>Település</td>
            <td>Jogállás</td>
            <td>Irányítószám</td>
        </tr>
    </thead>
    <tbody>
        @php
            $i = 0;
        @endphp
        @foreach ($result as $item)
            @php
                $i = $i + 1;
            @endphp
            <tr>
               <td>{{$i}}</td>
               <td><a href="/adatlap/{{$item->id}}">{{$item->nev}}</a></td>
               <td>{{$item->jogallas}}</td>
               <td>{{$item->iranyitoszam}}</td>
            </tr>

        @endforeach
    </tbody>

</table>

@endsection
