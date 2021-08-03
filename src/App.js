import React from 'react';
import { useState } from 'react';
import httpClient from '../src/httpClient';
import "./App.css";


function App() {
  const [userInfo, setUserInfo] = useState({
    otp: '',
    userId:'',
    remainingTime: 0});

    const handleUserId = e => {
      e.preventDefault();
      setUserInfo({ ...userInfo, ['userId']: e.target.value });
  }

    // Timer 
    const [counter, setCounter] = React.useState(0);
    React.useEffect(() => {
        const timer =
        counter > 0 && setInterval(() => setCounter(counter - 1), 1000);
        if (counter == 0) setUserInfo({ ...userInfo, ['otp']: '' });
        return () => clearInterval(timer);
    }, [counter]);

    const getOtp = () =>
     { 

      setUserInfo({ ...userInfo, ['otp']: '124556' }); setCounter(30); 

      /*const request = {userId: userInfo.userId, GenerationDate:Date().toLocaleString()}

      httpClient.post(`/Account/GenerateOtp`, request)
        .then(result => { if (result.errorMessage.length==0 )
        setUserInfo({ ...userInfo, ['otp']: result.password, ['remainingTime']: result.remainingseconds});}) */
    }

    
  return (
    userInfo['otp'] ==''?
    <div className="App">
     <div class="login" className="login"> 
                <h1>First login</h1>
                <input class="input-user" type="text" onChange={handleUserId} name="username"/>
                <button class="btn btn-warning" onClick={getOtp}>Get password 
                </button>
            </div>
    </div>:<div className="App">
              <div class="login" className="login"> 
                  <h1>Enter OTP</h1>
                  <div>
                    <input  class="input-otp" type="text" name="otp" maxlength="6" value={userInfo.otp} />
                  </div>
                  <button class="btn btn-warning">Verify</button>
              </div>
              <div>
                <p>Time left:{counter}</p>
              </div>
            </div>

  );
}

export default App;
