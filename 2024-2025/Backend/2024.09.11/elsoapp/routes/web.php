<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\EledelController;

Route::get('/', function () {
    return view('welcome');
});

Route::get('/eledel', function () {
    return view('eledel');
});
Route::get('/eledel', [EledelController::class, 'welcome']);
