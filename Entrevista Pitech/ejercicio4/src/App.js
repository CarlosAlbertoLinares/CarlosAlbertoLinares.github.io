import React,{Component} from 'react';
import './App.css';
import Item from './Item';
import Target from './Target';
import logo from './logo.png';
import HTML5Backend from 'react-dnd-html5-backend';
import {DragDropContext} from 'react-dnd';
import Problem from './Problem';

//  El programa contiene la "instruction", 1 problema y las opciones. Aún no me podido lograr que al darle click a un item "source" vaya directo 
// al target donde se visualiza la respuesta con la confirmación  de la validez de esta. Tampoco output en json.


class App extends Component{

  state = {
items: [
{id:1, name:'treinta y seis'},
{id:2 , name:'once mil'},
{id:3, name: 'ochenta y dos'},
{id:4, name: 'treinta y cinco'},
{id:5, name: 'mil novecientos'},
{id:6, name: 'cuarenta y siete'}

],
  }
deleteItem = (id) => {

  console.log('deleting id:' + id);
  this.setState(prevState => {
    let items = prevState.items;
    const index = items.findIndex(item => item.id === id);

    items.splice(index,1);

    return{items};
  });
}
render(){
  return(
<div className ="App">
<header className = "App-header">
<img src ={logo} className = "App-logo" alt="logo"/>
<h1 className ="App-title" > Escriba el número siguiente con letras haciendo click en la respuesta con el orden correcto: </h1>
</header>
<div className = "App-intro">
<Problem />
<div className = "app-container">
<div className = "item-container">
{this.state.items.map((item,index)=>(
  <Item key={item.id} item={item} handleDrop = {(id) => this.deleteItem(id)}/>
  ))}
</div>
<Target />
</div>
</div>
</div>
    );
}
}




export default DragDropContext(HTML5Backend)(App);
