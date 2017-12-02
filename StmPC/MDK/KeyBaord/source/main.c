/******************** (C) COPYRIGHT 2008 STMicroelectronics ********************
* File Name          : main.c
* Author             : Zachary(F.SB)
* Version            : V1.0
* Date               : 12/30/2013
* Description        : main file
********************************************************************************
* THE PRESENT FIRMWARE WHICH IS FOR GUIDANCE ONLY AIMS AT PROVIDING CUSTOMERS
* WITH CODING INFORMATION REGARDING THEIR PRODUCTS IN ORDER FOR THEM TO SAVE TIME.
* AS A RESULT, STMICROELECTRONICS SHALL NOT BE HELD LIABLE FOR ANY DIRECT,
* INDIRECT OR CONSEQUENTIAL DAMAGES WITH RESPECT TO ANY CLAIMS ARISING FROM THE
* CONTENT OF SUCH FIRMWARE AND/OR THE USE MADE BY CUSTOMERS OF THE CODING
* INFORMATION CONTAINED HEREIN IN CONNECTION WITH THEIR PRODUCTS.
*******************************************************************************/

/* Includes ------------------------------------------------------------------*/
//#include "stm32f10x_lib.h"
#include "usb_lib.h"
#include "hw_config.h"
#include "usb_pwr.h"
#include "../driver/tty.h"
#include "../driver/24l01.h"
#include "../driver/Delay.h"
#include "../driver/usart.h"
/* Private typedef -----------------------------------------------------------*/
/* Private define ------------------------------------------------------------*/
/* Private macro -------------------------------------------------------------*/
/* Private variables ---------------------------------------------------------*/
/* Extern variables ----------------------------------------------------------*/
/* Private function prototypes -----------------------------------------------*/
void Delay(vu32 nCount);

/* Private functions ---------------------------------------------------------*/
#define DEBUG
/*******************************************************************************
* Function Name  : main.
* Description    : main routine.
* Input          : None.
* Output         : None.
* Return         : None.
*******************************************************************************/
int main(void)
{
	u8 status;
	u8 con=1;
	
#ifdef DEBUG
  //debug();
#endif
	
  Set_System();
  Delay_init(72);
	tty_init();
	usart_init();
	
#ifdef DEBUG
	
	tty_printf("System completed\n");
	usart_send("test\n");
#endif
  USB_Interrupts_Config();
#ifdef DEBUG
	tty_printf("Interrupts completed\n");
#endif
  Set_USBClock();
#ifdef DEBUG
	tty_printf("USBClock completed\n");
#endif
  USB_Init();
#ifdef DEBUG	
	tty_printf("USB_Init completed\n");
#endif
	//NRF24L01_Init();
#ifdef DEBUG
	tty_printf("this is 2.4G init\n");
#endif
	status=0;
	while(1){
		DelayMs(1);
	}
		/*
  while(status==0){
		status=NRF24L01_Check();
		if(status)
				tty_printf("connect ok \n");				
		else
				tty_printf("connect failed \r\n");
		DelayMs(100);
	}
	
	status = NRF_RX_Mode();
#ifdef DEBUG
	tty_printf("Enter RevMode\n");
#endif  
	while (1)
  {
    if ((bDeviceState == CONFIGURED))
    {
				if(con){tty_printf("connected");con=0;}
				status = NRF_Rx_Dat((u8 *)&Package);
				if(status == 0){
					 tty_printf("receive Data:");
#ifdef DEBUG
					 tty_printf_H("%X",(u8*)&Package);
					 tty_printf("\n");
#endif
					 ReveiveCmd(Package);			
				}
    }
  }*/
	
	
}

/*******************************************************************************
* Function Name  : Delay
* Description    : Inserts a delay time.
* Input          : nCount: specifies the delay time length.
* Output         : None
* Return         : None
*******************************************************************************/
void Delay(vu32 nCount)
{
  for (; nCount != 0;nCount--);
}

#ifdef  DEBUG
/*******************************************************************************
* Function Name  : assert_failed
* Description    : Reports the name of the source file and the source line number
*                  where the assert_param error has occurred.
* Input          : - file: pointer to the source file name
*                  - line: assert_param error line source number
* Output         : None
* Return         : None
*******************************************************************************/
void assert_failed(u8* file, u32 line)
{
  /* User can add his own implementation to report the file name and line number,
     ex: printf("Wrong parameters value: file %s on line %d\r\n", file, line) */

  /* Infinite loop */
  while (1)
  {}
}
#endif


