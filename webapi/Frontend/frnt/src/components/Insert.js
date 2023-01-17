const Insert = () => {
    return (<div>

        <form action="/">
           Id: <input type="number" id="id" name="id"></input> <br/>
           Name: <input type="text" id="name" name="name"></input><br/>
           Sal: <input type="number" id="sal" name="sal"></input>  <br/>
           <button type="submit" >Insert</button>
        </form>
    </div>  );
}
 
export default Insert;