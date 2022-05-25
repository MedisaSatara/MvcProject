import { HttpClient } from '@angular/common/http';
import { Component, forwardRef, ViewChild, VERSION } from '@angular/core';
import { SharedService } from './shared.service';
import { EventsComponent } from './events/events.component';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'project_angular';
  @ViewChild(forwardRef(() => EventsComponent))
    eventsComponent: EventsComponent;
    

  constructor(public shared:SharedService){
  }


  sportNameSelected(event:any)
  {
    this.eventsComponent.getSportEvents(event);
  }

  categoryNameSelected(event:any)
  {
    this.eventsComponent.getCategoryEvents(event);
  }
  competitionNameSelected(event:any)
  {
    this.eventsComponent.getCompetitionEvents(event);
  }
  ShowAllEvents= function()
  {
  }

}
