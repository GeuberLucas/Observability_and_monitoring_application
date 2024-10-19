import http from 'k6/http';


export default function GetByIdPersonTest(apiUrl){
    let id = Math.floor(Math.random()) ;
    http.get(`http://${apiUrl}/api/Register/GetById/${id}`,{
        headers: {
            'Content-Type': 'application/json',
        },
    });
}