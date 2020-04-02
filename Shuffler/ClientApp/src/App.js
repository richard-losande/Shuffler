import React, { Component } from "react";
import { BrowserRouter,Switch, Route } from "react-router-dom";
import Cards from "./components/cards";


export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <BrowserRouter>    
        <Switch>
                <Route path="/" exact component={Cards} />
        </Switch>
        </BrowserRouter>
    );
  }
}
