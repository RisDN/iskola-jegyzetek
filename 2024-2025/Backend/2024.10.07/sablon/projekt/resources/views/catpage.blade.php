@extends('layout')
@section('content')

@php
    $cat = $result;
@endphp

<div class="container pb-2">
    <h1 class="text-center display-6 py-3">{{$cat->title}}</h1>


    <div class="row">
        <div class="col-md">
            <img class="img-fluid" src="{{{asset("/img/" . $cat->id . ".jpg")}}}" alt="">
        </div>
        <div class="col-md">
            <table class="table table-bordered">
                <tr class="border">
                    <td>Stock image page</td>
                    <td><a href="https://{{$cat->direct_link}}">{{$cat->site}}</a></td>
                </tr>
                <tr>
                    <td>Direct link to the pic</td>
                    <td><a href="https://{{$cat->direct_link}}">{{$cat->direct_link}}</a></td>
                </tr>
                <tr>
                    <td>Author</td>
                    <td>{{$cat->author}}</td>
                </tr>
                <tr>
                    <td>Author's page</td>
                    <td><a href="https://{{$cat->author_link}}">{{$cat->author_link}}</a></td>
                </tr>
            </table>
        </div>

        <div class="d-flex justify-content-center gap-2 mt-3">
            @if ($cat->id > 1)
                <a href="{{$cat->id - 1}}">Prev</a>
            @endif
            <span>||</span>
            <a href="{{$cat->id + 1}}">Next</a>
        </div>

</div>
@endsection
