<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Guestbook;
use Illuminate\Support\Facades\Log;

class GuestbookController extends Controller
{
    public function guestbook()
    {
        $guestbook = Guestbook::orderBy('date', 'desc')->get();

        return view('guestbook', ['guestbook' => $guestbook]);
    }

    public function addGuestbook(Request $req){
        $req -> validate([
            'nev' => 'required',
            'email' => 'required|email',
            'message' => 'required'
        ], [
            'nev.required' => 'A név megadása kötelező!',
            'email.required' => 'Az email cím megadása kötelező!',
            'email.email' => 'Az email cím formátuma nem megfelelő!',
            'message.required' => 'Az üzenet megadása kötelező!'
        ]);

        $data = new Guestbook;

        $data -> nev = $req -> nev;
        $data -> email = $req -> email;
        $data -> message = $req -> message;
        $data -> date = date('Y-m-d');

        $data -> save();
        
        return redirect('/guestbook') -> with('success', 'Az üzenet sikeresen elküldve');
    }
}
