import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ThemeService {
  constructor() {
    const theme = this.getFromLocalStorage();
    if (theme === 'dark') {
      this.toggleDarkMode();
    }
  }

  saveInLocalStorage(theme: 'light' | 'dark' = 'light') {
    localStorage.setItem('theme', theme);
  }

  getFromLocalStorage(): 'light' | 'dark' {
    const theme = localStorage.getItem('theme');
    return theme === 'dark' ? 'dark' : 'light';
  }

  toggleTheme() {
    const currentTheme = this.getFromLocalStorage();
    this.saveInLocalStorage();

    if (currentTheme === 'dark') {
      this.toggleLightMode();
    } else {
      this.toggleDarkMode();
    }
  }

  toggleDarkMode() {
    const html = document.documentElement;
    html.classList.toggle('dark');
    return 'dark';
  }

  toggleLightMode() {
    const html = document.documentElement;
    html.classList.remove('dark');
  }
}
