import { useState,useEffect } from "react";

import { useLocation } from "react-router-dom";

import Axios from 'axios';
const Edit = () => {
    let [empob,setempob]=useState({id:"",name:"",sal:""});
    let state=useLocation().state;
    
    useEffect(()=>{
        setempob({...state.employee})

    })
    const updateData=(empob)=>{
        Axios.put(`http://localhost:5034/Employee/${empob.id}`)
        .then((result)=>{
            console.log(result.data);
          //  history.push("/list");
        })
        .catch(()=>{})
    }
    
    const handleChange=(event)=>{
        const {name,value}=event.target;
        setempob({...empob,[name]:value});
    }

    return (<div>

        <form action="/">
           Id: <input type="number" 
                      id="id" 
                      name="id" 
                      value={empob.id}
                      onChange={handleChange}></input> <br/>
           Name: <input type="text" 
                        id="name" 
                        name="name"></input><br/>
           Sal: <input type="number" 
                       id="sal" 
                       name="sal"></input>  <br/>
           <button type="submit"  onClick={()=>updateData(empob)}>Insert</button>
        </form>
    </div>  );
}
 
export default Edit;