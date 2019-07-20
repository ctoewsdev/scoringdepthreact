import React from "react";
import HomePage from "./HomePage";
import LeaguesPage from "./LeaguesPage";
import RegionsPage from "./RegionsPage";
import AboutPage from "./AboutPage";
import FeedbackPage from "./FeedbackPage";
import Header from "./common/Header";
import { Route, Switch } from "react-router-dom";
import NotFoundPage from "./NotFoundPage";

function App() {
    return (
        <div className="container-fluid">
            <Header />
            <Switch>
                <Route exact path="/" component={HomePage} />
                <Route path="/regions" component={RegionsPage} />
                <Route path="/league" component={LeaguesPage} />
                <Route path="/feedback" component={FeedbackPage} />
                <Route path="/about" component={AboutPage} />
                <Route component={NotFoundPage} />
            </Switch>
        </div>
    );
}

export default App;