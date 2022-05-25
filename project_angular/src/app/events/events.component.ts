import { Component, Input, OnInit, Output } from '@angular/core';
import { SharedService } from '../shared.service';
import { Pipe, PipeTransform } from '@angular/core';
import { EventEmitter } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.css']
})


export class EventsComponent implements OnInit {

  constructor(public service:SharedService) { }
  EventList: any=[];

  ngOnInit(): void {
    this.refreshEventList();
  }

  refreshEventList()
  {
    this.service.getAllEvent().subscribe(data=>{
      this.EventList=data as any [];
    })
  }

  getSportEvents(event:any)
  {
    this.service.getEventsBySport(event).subscribe(data=>this.onSuccess(data))
  }
  getCategoryEvents(event:any)
  {
    this.service.getEventsByCategory(event).subscribe(data=>this.onSuccess(data))
  }
  getCompetitionEvents(event:any)
  {
    this.service.getEventsByCompetition(event).subscribe(data=>this.onSuccess(data))
  }
  onSuccess(data:any[])
  {
    this.EventList=data;
  }

  
 
  

  
 

}
