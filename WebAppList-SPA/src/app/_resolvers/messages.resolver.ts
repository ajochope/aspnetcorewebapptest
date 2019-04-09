import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { UserService } from '../_services/user.service';
import { AlertifyService } from '../_services/alertify.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { AuthService } from '../_services/auth.service';
import { Message } from '../_models/message';

@Injectable()
export class MessagesResolver implements Resolve<Message[]> {
    pageNumber = 1;
    pageSize = 5;
    messageContainer = 'Sin Leer';

    constructor(private userService: UserService,
                private router: Router,
                private authService: AuthService,
                private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<Message[]> {
        return this.userService
                   .getMessages(this.authService.decodedToken.nameid, this.pageNumber, this.pageSize, this.messageContainer)
                   .pipe(
                        catchError (error => {
                            this.alertify.error('Error: MessagesResolver: Descargando mensajes de este usuario');
                            this.router.navigate(['/home']);
                            return of(null);
                        })
                   );
    }
}
