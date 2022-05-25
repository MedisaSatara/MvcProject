import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import{HttpClientModule} from '@angular/common/http';
import { EventsComponent } from './events/events.component';
import { SharedService } from './shared.service';
import { SportComponent } from './events/sport/sport.component';
import { CategoryComponent } from './events/category/category.component';
import { CompetitionComponent } from './events/competition/competition.component';
import { FormsModule } from '@angular/forms';
import { FavoritetableComponent } from './events/favoritetable/favoritetable.component';

@NgModule({
  declarations: [
    AppComponent,
    EventsComponent,
    SportComponent,
    CategoryComponent,
    CompetitionComponent,
    FavoritetableComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
