<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\News;

class NewsController extends Controller
{
    public function news()
    {
        $news = News::orderBy('date', 'desc')->get();

        return view('news', ['news' => $news]);
    }
}
