var express=require('express');
var app=express();
app.get('/',function(req,resp){
    resp.sendFile("./public/profile.html",{root:__dirname})
})
app.listen(3000);
console.log("serverv is listening");