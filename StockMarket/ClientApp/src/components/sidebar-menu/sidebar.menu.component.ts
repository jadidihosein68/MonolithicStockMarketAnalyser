import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';

@Component({
  selector: 'app-side-menu',
  templateUrl: './sidebar.menu.component.html',
  styleUrls: ['./sidebar.menu.component.scss']
})
export class SideMenuComponent implements OnInit {
  isExpanded = false;


  constructor(public router: Router) {
    this.router.events.subscribe(val => {
        if (
            val instanceof NavigationEnd &&
            window.innerWidth <= 992 &&
            this.isToggled()
        ) {
            this.toggleSidebar();
        }
    });
}


toggleCollapsed() {
  this.collapsed = !this.collapsed;
  this.collapsedEvent.emit(this.collapsed);
}


isToggled(): boolean {
  const dom: Element = document.querySelector('body');
  return dom.classList.contains(this.pushRightClass);
}

toggleSidebar() {
  const dom: any = document.querySelector('body');
  dom.classList.toggle(this.pushRightClass);
}


rltAndLtr() {
  const dom: any = document.querySelector('body');
  dom.classList.toggle('rtl');
}




  @Output() collapsedEvent = new EventEmitter<boolean>();

  
  isActive: boolean;
  collapsed: boolean;
  showMenu: string;
  pushRightClass: string;


  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit() {
    this.isActive = false;
    this.collapsed = false;
    this.showMenu = '';
    this.pushRightClass = 'push-right';
}



}
