export interface Params {
    [key: string]: any;
}

export interface GetOptions {
    url: string;
    params?: Params;
}

export interface ErrorResponse {
    id: string;
    code: string;
    message: string;
}
