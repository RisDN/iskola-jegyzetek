<?php

use Illuminate\Support\Facades\Route;
use App\Http\Controllers\JarasController;

Route::get("/", [JarasController::class, 'welcome']);
Route::get("/telepulesek", [JarasController::class, 'telepulesek']);
Route::get("/adatlap/{id}", [JarasController::class, 'adatlap']);
