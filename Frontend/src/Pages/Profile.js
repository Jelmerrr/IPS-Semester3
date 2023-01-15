
import React, { useState, useEffect } from "react";
import '../Styles/App.css';


const ProfileName = "Hoi";



function Profile() {
    return (
        <div className="App">
            <header className="Profile">
                <div className='col-3 my-3 mx-3 border border-white '>
                    <p className="text-center fs-4">Character details</p>
                    <div className='my-3 mx-3 border border-white'></div>
                    <p className="text-center fs-5">Equipment</p>
                    <div className="row justify-content-center my-2">
                        <div className="col-3 border border-white">
                            <p className="text-center fs-5 my-3 mx-3" >&#9937;</p>
                        </div>
                    </div>
                    <div className="row justify-content-center my-2">
                        <div className="col-3 border border-white my-1 mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128481;</p>
                        </div>
                        <div className="col-3 border border-white my-1 mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128737;</p>
                        </div>
                    </div>
                    <div className="row justify-content-center my-2">
                        <div className="col-3 border border-white mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128141;</p>
                        </div>
                        <div className="col-3 border border-white mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128085;</p>
                        </div>
                        <div className="col-3 border border-white mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128141;</p>
                        </div>
                    </div>
                    <div className="row justify-content-center my-2">
                        <div className="col-3 border border-white my-1 mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128086;</p>
                        </div>
                        <div className="col-3 border border-white my-1 mx-1">
                            <p className="text-center fs-5 my-3 mx-3" >	&#128094;</p>
                        </div>
                    </div>
                    <div className='my-3 mx-3 border border-white'></div>
                    <p className="text-center fs-5">Character stats</p>

                    <p className="text-center fs-6">HP: 50</p>
                    <p className="text-center fs-6">DEF: 86</p>
                    <p className="text-center fs-6">ATK: 182</p>
                    <p className="text-center fs-6">SPD: 78</p>

                    <button type="button" class="btn btn-outline-light my-1 mx-1">Change gear</button>
                    <button type="button" class="btn btn-outline-light my-1 mx-1">Open inventory</button>
                </div>
                <div className='col-5 my-3 mx-3 border border-white '>
                    <p className="text-center fs-4">Player statistics</p>
                    <div className='my-3 mx-3 border border-white'></div>

                    <dl class="row">
                        <dt class="col-sm-3 fs-5 text-left">Class:</dt>
                        <dd class="col-sm-9 fs-5 text-left">Tank</dd>
                        <dt class="col-sm-3 fs-5 text-left">Level:</dt>
                        <dd class="col-sm-9 fs-5 text-left">15</dd>
                        <dt class="col-sm-3 fs-5 text-left">Gold:</dt>
                        <dd class="col-sm-9 fs-5 text-left">830</dd>
                        <dt class="col-sm-3 fs-5 text-left">Time played:</dt>
                        <dd class="col-sm-9 fs-5 text-left">8h 42min 18sec</dd>
                    </dl>
                </div>
                <div className='col-3 my-3 mx-3 border border-white '>
                    <p className="text-center fs-4">Friends</p>
                    <div className='my-3 mx-3 border border-white'></div>

                    <div class="mx-3 my-3">
                        <div class="card bg-light">
                            <h5 class="card-header text-black">Gert</h5>
                            <div class="card-body">
                                <h5 class="card-title text-black">Level 65 - Warrior</h5>
                                <p class="card-text text-success">Currently online.</p>
                                <a href="#" class="btn btn-outline-dark">Send message</a>
                            </div>
                        </div>
                    </div>

                    <div class="mx-3 my-3">
                        <div class="card bg-light">
                            <h5 class="card-header text-black">Samson</h5>
                            <div class="card-body">
                                <h5 class="card-title text-black">Level 28 - Mage</h5>
                                <p class="card-text text-danger">Currently offline. (last seen 2 hours ago)</p>
                                <a href="#" class="btn btn-outline-dark">Send message</a>
                            </div>
                        </div>
                    </div>
                </div>
                <p className="text-center fs-4">x</p>
            </header>
        </div>
    );
}
export default Profile;
