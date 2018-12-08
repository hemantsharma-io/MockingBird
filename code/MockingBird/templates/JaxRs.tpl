package com.example.requester;

import org.apache.hc.client5.http.entity.EntityBuilder;
import org.apache.hc.core5.http.HttpEntity;
import org.apache.http.client.methods.*;
import org.apache.http.impl.client.*;
import java.io.*;
import sun.misc.BASE64Decoder;

public class Requester{
    public static void main(String[] args) throws Exception{
        CloseableHttpClient closeableHttpClient = HttpClientBuilder.create().build();
{{#SelectedSessions}}
        org.apache.http.entity.AbstractHttpEntity entity = new org.apache.http.entity.ByteArrayEntity(new BASE64Decoder().decodeBuffer("{{RequestBodyAsBase64}}"));
        HttpUriRequest request = RequestBuilder.create("{{RequestMethod}}").setEntity(entity).setUri("{{fullUrl}}").build();
		{{#RequestHeaders}}
				request.addHeader("{{Name}}", "{{Value}}");
		{{/RequestHeaders}}
        CloseableHttpResponse closeableHttpResponse = closeableHttpClient.execute(request);

        processResponse(closeableHttpResponse);
{{/SelectedSessions}}
        System.out.println("end of request....");
    }

    private static void processResponse(CloseableHttpResponse closeableHttpResponse) throws Exception{
        BufferedReader brd = new BufferedReader(new InputStreamReader(closeableHttpResponse.getEntity().getContent()));
        String line = "";
        while((line = brd.readLine()) != null){
            System.out.print(line);
        }
    }
}