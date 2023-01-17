import { useState,useEffect } from "react";
import {Link} from 'react-router-dom'

import Axios from 'axios';
const Elist = () => {

   let[Emplist, SetEmplist]=useState([]);
    useEffect(()=>{
        Axios.get("http://localhost:5034/Employee").then(
            (res)=>{SetEmplist(res.data);}
            ).catch((err)=>{console.log(err);});
    })
    const DeleteE=( id)=>{
        Axios.delete(`http://localhost:5034/Employee/${id}`).then((response)=>{console.log(response.data)});
    }
    const renderList=()=>{
        return Emplist.map((obj)=>{
            return <tr> 
                <td>{obj.id}</td>
                <td>{obj.name}</td>
                <td>{obj.sal}</td>
                <td><button type="button" id="btn1" onClick={()=>DeleteE(obj.id)}>Delete</button></td>
                <td><Link to="/edit/{obj.id}"><button type="button" id="btn2" >Edit</button></Link></td>
            </tr>
        });
    }
    return ( <div>
<table>
    <thead>
<tr><th>ID</th><th>Name</th><th>Sal</th><th>edit</th><th>delete</th></tr>
</thead>
<tbody>
{renderList()}

</tbody>
</table>


    </div> );
}
 
export default Elist;