@extends('main')

@section('content')
    @if (session('success'))
    <div class="pt-3">
        <div class="text-center alert alert-success">
            {{ session('success') }}
        </div>
    </div>
    @elseif(session('error'))
    <div class="pt-3">
        <div class="text-center alert alert-danger">
            {{ session('error') }}
        </div>
    </div>
    @endif
    <div class="col-md-9">
        <h1 class="py-3 text-center">Polgármesteri köszöntő</h1>
        <p class="text-center">
            <b>Pusztaszentmária Község Önkormányzata nevében sok szeretettel köszöntöm honlapunk látogatóit!</b>
        </p>
        <p>
            Örülök, hogy időt szentel arra, hogy településünkkel részletesebben megismerkedjen. Ha szörfözik a világhálón, akkor láthatja, hogy községünkből csak egy van. Mi itt élők ezt tudjuk, nap mint nap tapasztaljuk. A település múltja nagyon gazdag és sokszínű. 
        </p>
        <p>
            Kérem kísérje figyelemmel honlapunkat, ahol igyekszünk bemutatni településünk múltját, jelenét, és jövőjét. A virtuálison túl személyes látogatásra is szívesen látjuk az ide utazókat, hisz meggyőzősésem, hogy a község és környékének szépsége, az itt lakók vendégszeretete elsősorban itt, helyben érzékelhető.
        </p>
        <p>
            Kiss Béla Lajos<br>
            polgármester
        </p>
    </div>
@endsection