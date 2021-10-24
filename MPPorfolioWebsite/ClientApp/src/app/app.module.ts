import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { SideNavMenuComponent } from './side-menu/side-menu.component';
import { CUSTOM_ELEMENTS_SCHEMA, NO_ERRORS_SCHEMA } from '@angular/core';
import { TopNavMenuComponent } from './top-nav-menu/top-nav-menu.component';
import { SkillsComponent } from './skills/skills.component';
import { CarouselComponent } from './carousels/carousel.component';
import { PortfolioComponent } from './portfolio/portfolio.component';
import { ServicesComponent } from './services/services.component';
import { ContactComponent } from './contact/contact.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    SideNavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    TopNavMenuComponent,
    SkillsComponent,
    CarouselComponent,
    PortfolioComponent,
    ServicesComponent,
    ContactComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'portfolio', component: PortfolioComponent },
      { path: 'services', component: ServicesComponent },
      { path: 'contact', component: ContactComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA,
    NO_ERRORS_SCHEMA
  ]
})


export class AppModule { }
